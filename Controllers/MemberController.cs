using Gym_Membership.Models.Context;
using Gym_Membership.Models.Dtos;
using Gym_Membership.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace Gym_Membership.Controllers
{
	public class MemberController : Controller
	{

		public IActionResult List()
		{
			var ctx = new GymMembershipContext();
			var list = ctx.Uyeler.ToList();
			return View(list);
		}

		[HttpGet]
		public IActionResult New()
		{ 


			return View();
		}

		[HttpPost]
		public IActionResult New([FromForm] MemberSaveDto dto)
		{
			var ctx = new GymMembershipContext();
			var entity = new Uye();
			entity.UyeAdi = dto.UyeAdi;
			entity.UyeSoyadi = dto.UyeSoyadi;
			entity.UyelikBaslangicTarihi = DateTime.Now.Date;
			entity.UyelikBitisTarihi = DateTime.Now.Date.AddMonths(dto.UyelikSuresi);
			ctx.Uyeler.Add(entity);
			ctx.SaveChanges();
			return RedirectToAction("List");
		}

		[HttpGet]
		public IActionResult Edit(int id)
		{
			var ctx = new GymMembershipContext();
			var edit = ctx.Uyeler.SingleOrDefault(x => x.Id == id);
			return View(edit);
		}

		[HttpPost]
		public IActionResult Edit([FromForm] MemberEditDto dto)
		{

			var ctx = new GymMembershipContext();
			var entity = ctx.Uyeler.SingleOrDefault(x => x.Id == dto.Id);
			entity.Id = dto.Id;
			entity.UyeAdi = dto.UyeAdi;
			entity.UyeSoyadi = dto.UyeSoyadi;
			entity.UyelikBitisTarihi = dto.UyelikBitisTarihi;

            ctx.Uyeler.Update(entity);
			ctx.SaveChanges();
			return RedirectToAction("List");
		}
		public IActionResult Delete(int id)
		{
			var ctx = new GymMembershipContext();
			var delete = ctx.Uyeler.SingleOrDefault(x => x.Id == id);

			ctx.Uyeler.Remove(delete);
			ctx.SaveChanges();
			return RedirectToAction("List");
		}
	}
}
