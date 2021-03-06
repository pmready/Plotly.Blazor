/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.Scatter3DLib.MarkerLib.ColorBarLib
{
    /// <summary>
    ///     Sets this color bar&#39;s vertical position anchor This anchor binds the
    ///     <c>y</c> position to the <c>top</c>, <c>middle</c> or <c>bottom</c> of the
    ///     color bar.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum YAnchorEnum
    {
        [EnumMember(Value=@"middle")]
        Middle = 0,
        [EnumMember(Value=@"top")]
        Top,
        [EnumMember(Value=@"bottom")]
        Bottom
    }
}