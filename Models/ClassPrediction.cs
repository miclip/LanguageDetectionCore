using Microsoft.ML.Runtime.Api;

namespace Models
{
     public class ClassPrediction
    {
        [ColumnName("PredictedLabel")]
        public float Class;
    }
}
