using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CsvHelper;
using Umbraco.Core.Models;
using Umbraco.Core.Media;
using Umbraco.Web.Mvc;
using Umbraco.Web;
using MissingLinkCoaching.Models.MissingLinkCoaching.Models;

namespace MissingLinkCoaching.Controllers
{
    public class CSVTrainingDataSurfaceController : Controller
    {
        public ActionResult CSVTrainingPlan(CSVTrainingPlanModel model)
        {
            List<String> trainingPlanIDs = new List<String>();
            UmbracoHelper uHelper = new UmbracoHelper(UmbracoContext.Current);
            string mediaUrl = "";
            var mediaItem = uHelper.ContentAtXPath("//TrainingPlans");
            mediaUrl = mediaItem.umbracoFile;
           
            var textReader = new StringReader(mediaUrl);

            var csv = new CsvReader(textReader);

            csv.Read();

            var records = csv.GetRecords<CSVTrainingDataSurfaceController>();
            
            model.Field= csv[0];
            
            return PartialView("_testView", null);
        }

    }
}


