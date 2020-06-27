using System.Collections.Generic;
using System.Linq;

namespace DatatablesServerside.DTModels
{
    /// <summary>
    /// The parameters sent by jQuery DataTables in AJAX queries.
    /// </summary>
    public class DataTableParams
    {
        private List<DataTableColumn> columns;
        private List<DTColumnOrder> order;

        /// <summary>
        /// Draw counter.
        /// This is used by DataTables to ensure that the Ajax returns from server-side processing requests are drawn in sequence by DataTables (Ajax requests are asynchronous and thus can return out of sequence).
        /// This is used as part of the draw return parameter (see below).
        /// </summary>
        public int Draw { get; set; }

        /// <summary>
        /// An array defining all columns in the table.
        /// </summary>
        public IEnumerable<DataTableColumn> Columns
        {
            get => columns;
            set
            {
                columns = value.ToList();
            }
        }

        /// <summary>
        /// An array defining how many columns are being ordering upon - i.e. if the array length is 1, then a single column sort is being performed, otherwise a multi-column sort is being performed.
        /// </summary>
        public IEnumerable<DTColumnOrder> Order
        {
            get => order;
            set
            {
                order = order.ToList();
            }
        }

        /// <summary>
        /// Paging first record indicator.
        /// This is the start point in the current data set (0 index based - i.e. 0 is the first record).
        /// </summary>
        public int Start { get; set; }

        /// <summary>
        /// Number of records that the table can display in the current draw.
        /// It is expected that the number of records returned will be equal to this number, unless the server has fewer records to return.
        /// Note that this can be -1 to indicate that all records should be returned (although that negates any benefits of server-side processing!)
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// Global search value. To be applied to all columns which have searchable as true.
        /// </summary>
        public DataTableSearchParam Search { get; set; }

        /// <summary>
        /// Custom column that is used to further sort on the first Order column.
        /// </summary>
        public string SortOrder => columns != null && order != null && order.Count() > 0
            ? (columns[order[0].Column].Data +
               (order[0].Dir == DtOrderDir.Desc ? " " + order[0].Dir : string.Empty))
            : null;

    }
}
