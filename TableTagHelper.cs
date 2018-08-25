using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp_net_core_tag_help_model_expression.Pages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

public class DataTableTagHelper : TagHelper
{
    public ModelExpression For { get; set; }

    public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        foreach (var item in For.Model as IEnumerable)
        {
            foreach (var prop in For.Metadata.ElementMetadata.Properties)
            {
                var name = prop.Name;
                var value = prop.PropertyGetter(item);
            }
        }

        return Task.CompletedTask;
    }
}