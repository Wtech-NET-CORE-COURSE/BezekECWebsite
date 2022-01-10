using System;
using System.Collections.Generic;
using System.Text;
using static ECommerceDataAccess.FilterProcess.FilterUtility;

namespace ECommerceDataAccess.FilterProcess
{
    public class FilterParams
    {
        public string ColumnName { get; set; } = string.Empty;
        public string FilterValue { get; set; } = string.Empty;
        public FilterOptions FilterOption { get; set; } = FilterOptions.Contains;
    }
}
