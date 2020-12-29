using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace healthApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]


    public class HeadController : Controller
    {
        // GET: /<controller>/

        //painpoints
        private static readonly string[] Name = new[]
       {
            "Tmj", "Sinus", "Cluster", "Tension", "Migraine","Neck"
        };

        //Paintpoint description
        private static readonly string[] Description = new[]
       {
            "Pain at temples in front of ears", "Pain behind backbone/cheekbone", "Pain in and aound the eye", "Pain like a band squeezing the head", "pain, nausea, visual changes","pain, at top and back of neck"
        };

        //causes
        private static readonly string[][] Causes = new string[][]
{
          new string[] {  "poor posture in neck and upper back",
          "stress",
          "chronic inflammatory arthritis",
          "jaw trauma",
          "excessive gum chewing" },
           new string[] { "Respiratory tract infections",
          "Allergies such as hay fever",
          "omplications of conditions such as cystic fibrosis and HIV",
          "Deviated nasal septum"},
           new string[] { "Weakness",
          "Numbness or tingling",
          "Sensitivity to light, sound, and smells",
          "Trouble speaking or hearing",
          "Colored spots, lines, flashing lights, or sparkles in your vision, called auras" },
          new string[] { "alcohol",
          "eye strain",
          "dry eyes",
          "fatigue",
          "smoking",
          "a cold or flu",
          "sinus infection",
          "caffine",
          "poor posture",
          "emotional stress",
          "decreased water intake" },
           new string[] { "Changes in the weather",
          "Too much or too little sleep",
          "Strong smells",
          "Stress",
          "Loud noises",
          "Too little food",
          "Anxiety or depression",
          "Hormone Changes" },
           new string[] { "poor posture",
          "working at a desk for too long without changing position",
          "sleeping with your neck in a bad position",
          "jerking your neck during exercise" }

};
       // Home-Remedies 
        private static readonly string[][] HomeRemedies = new string[][]
{
        new string[] {  "Practice Jaw exercise" },
        new string[] { "Avoid cigarette smoke and polluted air",
          "Use a humidifier",
          "Manage your allergies",
          "Avoid upper respiratory infections"},
        new string[] { "Keep a regular sleep schedule. A change to your routine can kick off a headache.",
          "Skip alcohol. Any type, even beer and wine, can trigger a bout of headaches when you’re in a cluster series.",
          "Find a quiet space where you won't be bothered",
          "Sit down and get comfy"},
        new string[] { "Apply an ice-pack on your head for 5-10mins",
          "Take hot bath/shower to relax tension muscles",
          "Improve your posture" },
        new string[] { "Keep a regular sleep schedule. A change to your routine can kick off a headache.",
          "Skip alcohol. Any type, even beer and wine, can trigger a bout of headaches when you’re in a cluster series.",
          "Find a quiet space where you won't be bothered",
          "Sit down and get comfy" },
        new string[] { "exercise, stretching, and physical therapy",
          "pain medication",
          "acupuncture",
          "pain medication" }

};


        [HttpGet]

        public IEnumerable<Painpoint> Get()
        {
            var rng = new Random();

            //creating JSON array of objects
            return Enumerable.Range(1, 5).Select(index => new Painpoint
            {
              
                name = Name[index],
                description = Description[index],
                causes = Causes[index],
                home_remedies = HomeRemedies[index]
            })
            .ToArray();


        }
    }
}

