using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace XOG.AppCode.Models
{
    public class EmailTemplateModel
    {
        public int ID;

        [Display(Name = "Template Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Template Desing")]
        [AllowHtml]
        [DataType(DataType.MultilineText)]
        public string HtmlMarkup { get; set; }

        [Display(Name = "Template Category")]
        public int TemplateCategory { get; set; }

        [Required]
        [Display(Name = "Template Name")]
        [DataType(DataType.Text)]
        public string TemplateName { get; set; }
    }
}