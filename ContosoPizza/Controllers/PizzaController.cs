using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController: ControllerBase
{
    PizzaService _service;
    public PizzaController(PizzaService service)
    {
        _service = service;
    }

    [HttpGet]
    public IEnumerable<Pizza> GetAll()
    {

        return _service.GetAll();
    }

    [HttpGet("{id}")]
    public ActionResult<Pizza> GetById(int id)
    {
        var pizza = _service.GetById(id);
        if(pizza == null)
        {
            return NotFound();
        }

        return pizza;
    }

    [HttpPost]
    public IActionResult Create(Pizza newPizza)
    {
        var pizza = _service.Create(newPizza);
        return CreatedAtAction(nameof(GetById), new {id =  pizza!.Id}, pizza);
    }
    [HttpPut("{id}/addtopping")]
    public IActionResult AddTopping(int id, int toppingId)
    {
        var pizzaToUpdate = _service.GetById(id);
        if(pizzaToUpdate == null)
        {
            return NotFound();
        }

        _service.AddTopping(id, toppingId);
        return NoContent();

    }
    [HttpPut("{id}/updatesauce")]
    public IActionResult UpdateSauce(int id, int sauceId)
    {
        var pizzaToUpdate = _service.GetById(id);
        if(pizzaToUpdate == null)
        {
            return NotFound();
        }
        
        _service.UpdateSauce(id, sauceId);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var pizza = _service.GetById(id);
        if(pizza == null)
        {
            return NotFound();
        }
        _service.DeleteById(id);    
        return Ok();

    }

}
