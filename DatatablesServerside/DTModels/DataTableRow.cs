using Newtonsoft.Json;

namespace DatatablesServerside.DTModels
{
    /// <summary>
    /// The additional columns that you can send to jQuery DataTables for automatic processing.
    /// </summary>
    public abstract class DataTableRow<T>
    {
        /// <summary>
        /// Set the ID property of the dt-tag tr node to this value
        /// </summary>
        [JsonProperty("DT_RowId")]
        public virtual string DtRowId { get; set; }
        /// <summary>
        /// Add this class to the dt-tag tr node
        /// </summary>
        [JsonProperty("DT_RowClass")]
        public virtual string DtRowClass { get; set; }

        /// <summary>
        /// Add this data property to the row's dt-tag tr node allowing abstract data to be added to the node, using the HTML5 data-* attributes.
        /// This uses the jQuery data() method to set the data, which can also then be used for later retrieval (for example on a click event).
        /// </summary>
        [JsonProperty("DT_RowData")]
        public virtual object DtRowData { get; set; }
        /// <summary>
        /// Add the data contained in the object to the row tr node as attributes. 
        /// The object keys are used as the attribute keys and the values as the corresponding attribute values.
        /// This is performed using using the jQuery param() method. 
        /// Please note that this option requires DataTables 1.10.5 or newer.
        /// </summary>
        [JsonProperty("DT_RowAttr")]
        public object DtRowAttr { get; set; }
    }
}
