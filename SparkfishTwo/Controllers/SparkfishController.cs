using MediatR;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Runtime.Serialization;

namespace SparkfishTwo.Controllers;


[ApiController]
[Route("api/")]
public class SparkfishController : ControllerBase
{


    [HttpGet]
    [Route("listify")]
    public async Task<ActionResult<int>> Get([FromQuery] BeginEndIndexDto request)
    {

        return await FindValueByIndex(request.Begin, request.Count, request.Index);

    }

    
    private async Task<ActionResult<int>> FindValueByIndex(int begin, int count, int index)
    {

        if (index < 0 || index > count)
        {
            throw new ArgumentOutOfRangeException();
        }


        var list = new List<int>();

        foreach (int i in Enumerable.Range(begin, count))
        {
            list.Add(i);
        };

        return await Task.FromResult(list[index]);

    }

}

