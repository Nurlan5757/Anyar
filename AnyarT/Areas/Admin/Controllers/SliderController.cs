using AnyarT.DAL;
using AnyarT.Models;
using AnyarT.ViewModels.Sliders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnyarT.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController(AnyarTContext _context) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var data = await _context.sliders
                .Select(s => new GetSliderAdminVM
                {
                    Id = s.Id,
                    FullName= s.FullName,
                    Subtitle1 = s.FullName,
                    Subtitle2 = s.FullName,
                    ImageUrl = s.ImageUrl,
                    IsDeleted = s.IsDeleted,
                }).ToListAsync();
            return View(data);
        }
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateSliderVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            Slider slider = new Slider
            {
                FullName = vm.FullName,
                ImageUrl = vm.ImageUrl,
                Subtitle1 = vm.Subtitle1,
                Subtitle2 = vm.Subtitle2,
            };
            await _context.sliders.AddAsync(slider);
            await _context.SaveChangesAsync();
            return View();
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null || id < 1) return BadRequest();
            Slider slider = await _context.sliders.FirstOrDefaultAsync(s => s.Id == id);

            if (slider is null) return NotFound();

            UpdateSliderVM sliderVM = new UpdateSliderVM
            {
                FullName = slider.FullName,
                ImageUrl = slider.ImageUrl,
                Subtitle1 = slider.Subtitle1,
                Subtitle2 = slider.Subtitle2,
            };
            return View(sliderVM);
        }
        [HttpPost]
        public async Task<IActionResult> Update(int? id, UpdateSliderVM sliderVM)
        {

            if (id == null || id < 1) return BadRequest();
            Slider ecisted = await _context.sliders.FirstOrDefaultAsync(s => s.Id == id);

            if (ecisted is null) return NotFound();

            ecisted.FullName = sliderVM.FullName;
            ecisted.ImageUrl = sliderVM.ImageUrl;
            ecisted.Subtitle1 = sliderVM.Subtitle1;
            ecisted.Subtitle2 = sliderVM.Subtitle2;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || id < 1) return BadRequest();
            var d = await _context.sliders.FindAsync(id);
            if (d is null) return BadRequest();
            _context.sliders.Remove(d);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
    
}
