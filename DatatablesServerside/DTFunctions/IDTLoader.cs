using DatatablesServerside.DTModels;

namespace DatatablesServerside.DTFunctions
{
    /// <summary>
    /// Loads the the datatable
    /// </summary>
    /// <typeparam name="T">tType of Data table reutrn data</typeparam>
    public interface IDTLoader<T>
    {
        /// <summary>
        /// Loads the data table and generate the datatable result
        /// </summary>
        /// <typeparam name="U">Type of parameter to be used to fetch data from the db</typeparam>
        /// <param name="dbParam">parameter to be sent to the database to filter data</param>
        /// <param name="dtParam">data table paramerters</param>
        /// <returns></returns>
        DataTableResult<T> LoadDataTable<U>(U dbParam, DataTableParams dtParam);
    }
}
