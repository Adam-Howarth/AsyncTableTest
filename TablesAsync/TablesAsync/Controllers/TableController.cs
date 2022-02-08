using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TablesAsync.Controllers
{
	public class TableController : Controller
	{
		public ActionResult Desktop()
		{
			return new PartialViewResult
			{
				ViewName = "~/Views/Tables/_DesktopTable.cshtml"
			};
		}

		public ActionResult Mobile()
		{
			return new PartialViewResult
			{
				ViewName = "~/Views/Tables/_MobileTable.cshtml"
			};
		}
	}
}