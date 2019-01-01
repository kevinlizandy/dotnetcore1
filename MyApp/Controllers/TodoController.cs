using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Controllers
{
    [Route("api/[controller]")]     
    [ApiController]     
    public class TodoController : ControllerBase     
    {        
        private readonly TodoContext _context;          

        public TodoController(TodoContext context)         
        {             
            _context = context;              
            // if (_context.Todos.Count() == 0)             
            // {                 
            //     _context.Todos.Add(new Todo { Id = 1, Title = "One", IsDone = true });                 
            //     _context.SaveChanges();             
            // }         
        } 

        [HttpGet] 
        public ActionResult<List<Todo>> GetAll() 
        {     
            return _context.Todos.ToList(); 
        }

        [HttpPost]
        //[ActionName("create")] 
        public Todo create(Todo data) 
        {     
            _context.Todos.Add(data);
            _context.SaveChanges();
            return data; 
        } 
        
        [HttpGet("{id}", Name = "GetTodo")] 
        public ActionResult<Todo> GetById(long id) 
        {    
            var item = _context.Todos.Find(id);     
            if (item == null)    
            {         
                return NotFound();     
            }     
            return item; 
        }           
    } 
}
