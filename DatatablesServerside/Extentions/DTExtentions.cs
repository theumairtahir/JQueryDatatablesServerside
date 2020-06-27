using DatatablesServerside.DTModels;
using System.Collections.Generic;

namespace DatatablesServerside.Extentions
{
    public static class DTExtentions
    {
        public static DataTableResult<T> ToDataTable<T>(this List<T> data, int dtDraw, int totalRecord)
        {
            DataTableResult<T> result = new DataTableResult<T>
            {
                Data = data,
                Draw = dtDraw,
                RecordsFiltered = data.Count,
                RecordsTotal = totalRecord
            };
            return result;
        }
    }
}
