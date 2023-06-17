using ASP_GlassClassification.Glass_Classification;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ML;

namespace ASP_GlassClassification.Controllers
{
    public class PredictionController : Controller
    {
        private readonly MLContext _mlContext;
        private readonly ITransformer _model;

        public PredictionController()
        {
            _mlContext = new MLContext();
            _model = _mlContext.Model.Load("MLModels/GlassClassification.zip", out _);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(InputModel input)
        {
            var predictionEngine = _mlContext.Model.CreatePredictionEngine<InputModel, ResultModel>(_model);
            var prediction = predictionEngine.Predict(input);

            return View(prediction);
        }
    }
}
