﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeaveManagment.Web.Data;
using AutoMapper;
using LeaveManagment.Web.Models;
using LeaveManagment.Web.Contracts;
using Microsoft.AspNetCore.Authorization;
using LeaveManagment.Web.Constants;

namespace LeaveManagment.Web.Controllers
{
    [Authorize(Roles = Roles.Administrator)]
    public class LeaveTypesController : Controller
    {
        //private readonly ApplicationDbContext _context;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;

        public LeaveTypesController(ILeaveTypeRepository leaveTypeRepository, IMapper mapper, ILeaveAllocationRepository leaveAllocationRepository /*ApplicationDbContext context*/)
        {
            //_context = context
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
            _leaveAllocationRepository = leaveAllocationRepository;
        }

        // GET: LeaveTypes
        public async Task<IActionResult> Index()
        {
            // Select * from LeaveTypes
            //mapp to LeaveTypeVM
            var leaveTypes = _mapper.Map<List<LeaveTypeVM>>(await _leaveTypeRepository.GetAllAsync()/*await _context.LeaveTypes.ToListAsync()*/);
            return View( leaveTypes );
            //return _context.LeaveTypes != null ?
            //              View(leaveTypes) : 
            //              Problem("Entity set 'ApplicationDbContext.LeaveTypes'  is null.");
        }

        // GET: LeaveTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            var leaveType = await _leaveTypeRepository.GetAsync(id); // ne treba id.Value posto je id? nullable
            if (leaveType == null)
            {
                return NotFound();
            }
            //var leaveType = await _context.LeaveTypes
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (leaveType == null)
            //{
            //    return NotFound();
            //}

            var leaveTypeVm = _mapper.Map<LeaveTypeVM>(leaveType);
            return View(leaveTypeVm);
        }

        // GET: LeaveTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LeaveTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(/*[Bind("Name,DefaultDays,Id,DateCreated,DateModified")] - ne treba kad koristimo ViewModel*/ LeaveTypeVM leaveTypeVM)
        {
            if (ModelState.IsValid)
            {
                // moramo mappirati zato sto _context je povezan sa db, a koji prihvata LeaveType, a ne LeaveTypeVM
                var leaveType = _mapper.Map<LeaveType>(leaveTypeVM);
                //_context.Add(leaveType);
                //await _context.SaveChangesAsync();
                await _leaveTypeRepository.AddAsync(leaveType);
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
        }

        // GET: LeaveTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var leaveType = await _context.LeaveTypes.FindAsync(id);
            var leaveType = await _leaveTypeRepository.GetAsync(id);
            if (leaveType == null)
            {
                return NotFound();
            }
            //convert to ViewModel version and then return ViewModel version
            var leaveTypeVm = _mapper.Map<LeaveTypeVM>(leaveType);
            return View(leaveTypeVm);
        }

        // POST: LeaveTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, LeaveTypeVM leaveTypeVM)
        {
            if (id != leaveTypeVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var leaveType = _mapper.Map<LeaveType>(leaveTypeVM);
                    //_context.Update(leaveType);
                    //await _context.SaveChangesAsync();
                    await _leaveTypeRepository.UpdateAsync(leaveType);
                }
                catch (DbUpdateConcurrencyException) //if 2 or more users make changes simultaneously 
                {
                    //if (!await LeaveTypeExists(leaveTypeVM.Id))
                    if (!await _leaveTypeRepository.Exists(leaveTypeVM.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
        }

        // GET: LeaveTypes/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var leaveType = await _context.LeaveTypes
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (leaveType == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(leaveType);
        //}

        // POST: LeaveTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //if (_context.LeaveTypes == null)
            //{
            //    return Problem("Entity set 'ApplicationDbContext.LeaveTypes'  is null.");
            //}
            //var leaveType = await _context.LeaveTypes.FindAsync(id);
            //if (leaveType != null)
            //{
            //    _context.LeaveTypes.Remove(leaveType);
            //}
            
            //await _context.SaveChangesAsync();
            await _leaveTypeRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        //private async Task<bool> LeaveTypeExists(int id)
        //{
        //  //return (_context.LeaveTypes?.Any(e => e.Id == id)).GetValueOrDefault();
        //  return await _leaveTypeRepository.Exists(id);
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AllocateLeave(int id)
        {
            await _leaveAllocationRepository.LeaveAllocation(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
