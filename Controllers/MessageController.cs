using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageBoard22.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MessageBoard22.Controllers
{
    [Route("api/Message")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly MessageDataContext  contextThis;

        public MessageController(MessageDataContext context)
        {
            contextThis = context;

         
        }
       
    
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

            // GET api/<controller>/5
            [HttpGet("{id}")]
            public async Task<ActionResult<MessageData>> GetMessageData(int  id)
            {
                var messageData = await contextThis.messageData.FindAsync(id);

                if (messageData == null)
                {
                    return NotFound();
                }

                return messageData;
            }

        // POST api/<controller>
            [HttpPost]
        public async Task<ActionResult<MessageData>> PostTodoItem(MessageData message)
        {
            contextThis.messageData.Add(message);
            await contextThis.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMessageData), new { id = message.id }, message);
        }
        /*public void Post([FromBody]string value)
        {
        }*/

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
