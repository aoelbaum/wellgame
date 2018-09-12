Shader "Custom/ApplyTexture" 
{
	Properties //variables
	{
		_MainTex("Main Texture (RBG)", 2D) = "white" {} //Allows for a texture property
		_Color("Color", Color) = (1,1,1,1) //Allows for color property
	}

	SubShader
	{
		Pass
		{
			CGPROGRAM //Allows talk between two languages: shader lab and nvidia c for graphics

			//Function Defines the name for vertex and fragment functions
			#pragma vertex vert //Define for the building function
			#pragma fragment frag // Define for the coloring function

			#include "UnityCG.cginc" //Built in shader functions 
			//Structures can get data like verticies, normal, color, uv

			struct appdata
			{
				float4 vertex : POSITION;
				float uv : TEXCOORD0;
			};

			struct v2f
			{	
				float4 pos : SV_POSITION;
				float2 uv : TEXCOORD0;
			};

			float4 _Color;
			sampler2D _MainTex;

			v2f vert(appdata IN)
			{
				v2f OUT;

				OUT.pos = UnityObjectToClipPos(IN.vertex);
				OUT.uv = IN.uv;

				return OUT;
			}

			fixed4 frag(v2f IN) : SV_Target

			{
				float4 texColor = tex2D(_MainTex, IN.uv);
				return texColor * _Color;
			}

			ENDCG
		}
	}
	
}
