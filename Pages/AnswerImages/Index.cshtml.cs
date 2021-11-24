using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab05.Models;

namespace Lab05.Pages.AnswerImages
{
    public class IndexModel : PageModel
    {
        private readonly Lab05.Data.AnswerImageDataContext _context;

        public IndexModel(Lab05.Data.AnswerImageDataContext context)
        {
            _context = context;
        }

        public IList<AnswerImage> AnswerImage { get;set; }

        public async Task OnGetAsync()
        {
            AnswerImage = await _context.AnswerImage.ToListAsync();

            
        }
    }
}
