﻿using System;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using AFT.RegoV2.AdminWebsite.Common.jqGrid;
using Newtonsoft.Json;

namespace AFT.RegoV2.AdminApi.Filters
{
    public class SearchPackageFilterAttribute : ActionFilterAttribute
    {
        public string ParameterName { get; private set; }

        public SearchPackageFilterAttribute(string parameterName)
        {
            ParameterName = parameterName;
        }

        #region IActionFilter Members
        public override void OnActionExecuting(HttpActionContext filterContext)
        {
            SearchPackage searchPackage = new SearchPackage();

            var context = new HttpContextWrapper(HttpContext.Current);

            HttpRequestBase request = context.Request;

            string temp = request["_search"];
            if (string.IsNullOrEmpty(temp) || temp.Equals("false", StringComparison.OrdinalIgnoreCase))
            {
                searchPackage.SingleFilter = new SingleFilter(null, ComparisonOperator.none, null);
            }
            else
            {
                ComparisonOperator comparisonOperator = ComparisonOperator.none;
                if (!string.IsNullOrEmpty(request["searchOper"]))
                {
                    comparisonOperator = (ComparisonOperator)Enum.Parse(typeof(ComparisonOperator), request["searchOper"]);
                }

                searchPackage.SingleFilter = new SingleFilter(request["searchField"], comparisonOperator, request["searchString"]);

                searchPackage.AdvancedFilter = JsonConvert.DeserializeObject<AdvancedFilter>(request["filters"]);
            }
            if (request["page"] != null)
            {
                searchPackage.PageIndex = int.Parse(request["page"]);
            }
            if (request["rows"] != null)
            {
                searchPackage.RowCount = int.Parse(request["rows"]);
            }
            if (request["sidx"] != null)
            {
                searchPackage.SortColumn = request["sidx"];
            }
            if (request["sord"] != null)
            {
                searchPackage.SortSord = request["sord"];
            }
            if (request["toprecords"] != null)
            {
                int toprecords = 0;
                if (int.TryParse(request["toprecords"], out toprecords))
                {
                    searchPackage.TopRecords = toprecords;
                }
            }
            temp = request["sord"];
            searchPackage.SortASC = string.IsNullOrEmpty(temp) || temp.Equals("asc", StringComparison.OrdinalIgnoreCase);

            filterContext.ActionArguments[ParameterName] = searchPackage;
        }
        #endregion
    }
}
