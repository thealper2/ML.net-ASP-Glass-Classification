using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_GlassClassification.Glass_Classification
{
    public class ResultModel
    {
        [ColumnName("PredictedLabel")]
        public Single Prediction { get; set; }

        public float[] Score { get; set; }
    }
}
