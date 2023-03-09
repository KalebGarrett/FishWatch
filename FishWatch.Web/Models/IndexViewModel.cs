using System.Collections.Generic;
using FishWatch.Models;

namespace FishWatch.Web.Models
{
    public class IndexViewModel
    {
        public List<Fish> Fishes { get; set; } = new List<Fish>();
    }
}