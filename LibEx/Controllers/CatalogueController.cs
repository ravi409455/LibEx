using LibEx.ViewModels.Catalogue;
using LibraryData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibEx.Controllers
{
    public class CatalogueController : Controller
    {
        private readonly ILibraryAsset _asset;

        public CatalogueController(ILibraryAsset asset)
        {
            _asset = asset;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Library Catalogue";
            var assetModels = _asset.GetAll();
            var listingResult = assetModels
                .Select(result => new AssetIndexListing
                {
                    Id = result.Id,
                    ImageUrl = result.ImageUrl,
                    AuthorOrDirector = _asset.GetAuthorOrDirector(result.Id),
                    DeweyCallNumber = _asset.GetDeweyIndex(result.Id).ToString(),
                    Title = result.Title,
                    Type = _asset.GetType(result.Id)
                });

            var model = new AssetIndexModel()
            {
                Assets = listingResult
            };
            return View(model);
        }
    }
}
