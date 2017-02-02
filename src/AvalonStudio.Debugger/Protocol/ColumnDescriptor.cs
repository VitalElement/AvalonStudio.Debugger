using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AvalonStudio.Debugger.Protocol
{
    /// <summary>
    /// A ColumnDescriptor specifies what module attribute to show in a column of the ModulesView, how to format it, and what the column's label should be.
    /// It is only used if the underlying UI actually supports this level of customization.
    /// </summary>
    public class ColumnDescriptor
    {
        /// <summary>
        /// Name of the attribute rendered in this column.
        /// </summary>
        [JsonProperty("attributeName")]
        public string AttributeName { get; set; }

        /// <summary>
        /// Header UI label of column.
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }

        /// <summary>
        /// Format to use for the rendered values in this column. TBD how the format strings looks like.
        /// </summary>
        [JsonProperty("format")]
        public string Format { get; set; }

        /// <summary>
        /// Datatype of values in this column.  Defaults to 'string' if not specified.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public ColumnDataType Type { get; set; }

        /// <summary>
        /// Width of this column in characters (hint only).
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }
    }

    public enum ColumnDataType { String, Number, Boolean, UnixTimestampUTC }
}
