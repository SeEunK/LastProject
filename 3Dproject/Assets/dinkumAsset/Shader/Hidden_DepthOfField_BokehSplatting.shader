//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/DepthOfField/BokehSplatting" {
Properties {
_MainTex ("", 2D) = "white" { }
_BlurredColor ("", 2D) = "white" { }
_FgCocMask ("", 2D) = "white" { }
}
SubShader {
 Pass {
  Blend DstAlpha One, Zero One
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 59515
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
Program "gp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
}
}
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 93582
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