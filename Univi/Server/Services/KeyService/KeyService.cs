using Microsoft.EntityFrameworkCore;
using System.Linq;
using Univi.Server.Data;
using Univi.Shared;

namespace Univi.Server.Services.KeyService
{
    public class KeyService : IKeyservice
    {
        #region CTOR
        private readonly ApplicationDbContext _context;

        public KeyService(ApplicationDbContext context)
        {
            _context = context;
        }
        #endregion
        #region POST
        public async Task<KeyIssue?> CreateKeyIssue(KeyIssue key)
        {
            var current = key.IssuedByUserId;
            

            var issue = new KeyIssue
            {
                IsRenturned = false, //Set the status to not returned
                DateCreated = key.DateCreated,
                KeyId = key.KeyId,
                EmployeeId = key.EmployeeId, //Issued to emplyee

                //Issued if not a employee
                FirstName = key.FirstName,
                LastName = key.LastName,
                Email = key.Email,
                Phone = key.Phone
            };
            if (issue != null) // Check if the Keyissue is valid. Then set the current key status from the keyslist to NOT RETURNED
            {
                var currentKey = _context.KeysList.Where(m => m.Id == issue.KeyId).FirstOrDefault();
                if (currentKey != null)
                {
                    currentKey.IsReturned = false;
                    _context.KeysList.Update(currentKey);
                }
                await _context.KeyIssues.AddAsync(issue);
                await _context.SaveChangesAsync();
            }
            return key;
        }
        #endregion
        #region GET

        public Task<KeyIssue?> GetKeyissueById(string id)
        {
            throw new NotImplementedException();
        }
        //Get a list of all keyissues
        public async Task<List<KeyIssue>> GetKeyIssues()
        {
            var result = await _context.KeyIssues.ToListAsync();
            return result;
        }

        //Get a list of all keylist items
        public async Task<List<KeyList>> GetKeyList()
        {

            var result = await _context.KeysList.ToListAsync();
            return result;
        }

        public async Task<List<KeyList>> GetReturnedKeys()
        {
            //Only show the keys which are returned.
            var result = await _context.KeysList.Where(m => m.IsReturned == true).ToListAsync();
            return result;
        }

        public async Task<KeyIssue?> SetKeyReturned(string id)
        {
            //Find the current key and set IsReturned to TRUE
            var item = await _context.KeyIssues.FindAsync(id);

            if (item != null)
            {
                var issue = _context.KeysList.Where(m => m.Id == item.KeyId).FirstOrDefault();
                if (issue != null)
                {

                    item.IsRenturned = true;
                    issue.IsReturned = true;
                    //Check if both values are set to true,Then save the changes
                    if (issue.IsReturned == true && item.IsRenturned == true)
                    {
                        _context.KeyIssues.Update(item);
                        _context.KeysList.Update(issue);
                        await _context.SaveChangesAsync();
                        return item;
                    }
                }
            }
            return null;
        }
        #endregion
    }
}

