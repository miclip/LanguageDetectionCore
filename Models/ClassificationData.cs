using Microsoft.ML.Runtime.Api;

namespace Models
{
     public class ClassificationData
    {
        [Column(ordinal: "0", name: "Label")]
        public float LanguageClass;

        [Column(ordinal: "1")]
        public string Text;
    }
}
