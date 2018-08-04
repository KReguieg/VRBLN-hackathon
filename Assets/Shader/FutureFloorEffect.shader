﻿Shader "Unlit/FutureFloorEffect"
{
	Properties
	{
		_MainTex ("Texture", 2D) = "white" {}
		[HDR]_EmissionColor("Emission Color", Color) = (0,0,0,0)
		_VolumeSize("Volume Size", Vector) = (0,0,0,0)
		_FadingSpeed("Speed", float) = 0
	}
	SubShader
	{
		Tags { "RenderType"="Opaque" }
		LOD 100
		Blend SrcAlpha OneMinusSrcAlpha

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			// make fog work
			#pragma multi_compile_fog
			#include "UnityCG.cginc"


			float3 _EmissionColor;
			float2 _VolumeSize;
			float _FadingSpeed;

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				UNITY_FOG_COORDS(1)
				float4 vertex : SV_POSITION;
				float4 worldPos : TEXCOORD2;
			};

			float hash( float n )
			{
				return frac(sin(n)*43758.5453);
			}
			
			float noise( float3 x )
			{
				// The noise function returns a value in the range -1.0f -> 1.0f
			
				float3 p = floor(x);
				float3 f = frac(x);
			
				f       = f*f*(3.0-2.0*f);
				float n = p.x + p.y*57.0 + 113.0*p.z;
			
				return lerp(lerp(lerp( hash(n+0.0), hash(n+1.0),f.x),
							lerp( hash(n+57.0), hash(n+58.0),f.x),f.y),
						lerp(lerp( hash(n+113.0), hash(n+114.0),f.x),
							lerp( hash(n+170.0), hash(n+171.0),f.x),f.y),f.z);
			}

			sampler2D _MainTex;
			float4 _MainTex_ST;
			
			v2f vert (appdata v)
			{
				v2f o;
				o.worldPos = v.vertex;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				UNITY_TRANSFER_FOG(o,o.vertex);
				return o;
			}
			
			fixed4 frag (v2f i) : SV_Target
			{
				i.worldPos.z *= _VolumeSize.x;
				i.worldPos.x *= _VolumeSize.y;
				float a = (noise(i.worldPos + _Time.y / _FadingSpeed) -0.5)*2;
				if(a<0)
					a = 0;
				fixed4 col = fixed4( _EmissionColor, a );

				UNITY_APPLY_FOG(i.fogCoord, col);
				return col;
			}
			ENDCG
		}
	}
	
}
