//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/TonemappingColorGrading" {
Properties {
_MainTex ("Texture", 2D) = "white" { }
}
SubShader {
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  Fog {
   Mode Off
  }
  GpuProgramID 33439
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
}
}
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  Fog {
   Mode Off
  }
  GpuProgramID 128075
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
}
}
 Pass {
  Blend SrcAlpha OneMinusSrcAlpha, SrcAlpha OneMinusSrcAlpha
  ZTest Always
  ZWrite Off
  Cull Off
  Fog {
   Mode Off
  }
  GpuProgramID 132941
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
}
}
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  Fog {
   Mode Off
  }
  GpuProgramID 225706
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
}
}
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  Fog {
   Mode Off
  }
  GpuProgramID 292233
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
}
}
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  Fog {
   Mode Off
  }
  GpuProgramID 369599
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
}
}
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  Fog {
   Mode Off
  }
  GpuProgramID 407720
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
}
}
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  Fog {
   Mode Off
  }
  GpuProgramID 504400
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
}
}
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  Fog {
   Mode Off
  }
  GpuProgramID 552944
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
}
}
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  Fog {
   Mode Off
  }
  GpuProgramID 643609
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
}
}
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  Fog {
   Mode Off
  }
  GpuProgramID 694025
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "ENABLE_COLOR_GRADING" "ENABLE_DITHERING" "ENABLE_EYE_ADAPTATION" "GAMMA_COLORSPACE" }
"// shader disassembly not supported on DXBC"
}
}
}
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  Fog {
   Mode Off
  }
  GpuProgramID 764670
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
}
}
}
}