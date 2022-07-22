using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CommunicationsApi.Models;
using CommunicationsApi.Models.Data;

namespace CommunicationsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly MessageContext _context;

        public MessagesController(MessageContext context)
        {
            _context = context;
        }

        // GET: api/Messages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MessageModel>>> GetMessageModel()
        {
          if (_context.MessageModel == null)
          {
              return NotFound();
          }
            return await _context.MessageModel.ToListAsync();
        }

        // GET: api/Messages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MessageModel>> GetMessageModel(int id)
        {
          if (_context.MessageModel == null)
          {
              return NotFound();
          }
            var messageModel = await _context.MessageModel.FindAsync(id);

            if (messageModel == null)
            {
                return NotFound();
            }

            return messageModel;
        }

        // PUT: api/Messages/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMessageModel(int id, MessageModel messageModel)
        {
            if (id != messageModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(messageModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MessageModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Messages
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MessageModel>> PostMessageModel(MessageModel messageModel)
        {
          if (_context.MessageModel == null)
          {
              return Problem("Entity set 'MessageContext.MessageModel'  is null.");
          }
            _context.MessageModel.Add(messageModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMessageModel", new { id = messageModel.Id }, messageModel);
        }

        // DELETE: api/Messages/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMessageModel(int id)
        {
            if (_context.MessageModel == null)
            {
                return NotFound();
            }
            var messageModel = await _context.MessageModel.FindAsync(id);
            if (messageModel == null)
            {
                return NotFound();
            }

            _context.MessageModel.Remove(messageModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MessageModelExists(int id)
        {
            return (_context.MessageModel?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
