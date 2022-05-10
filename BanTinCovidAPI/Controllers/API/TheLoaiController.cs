using BanTinCovidAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BanTinCovidAPI.Controllers.API
{
    public class TheLoaiController : ApiController
    {
        public IHttpActionResult GetAllTheLoai()
        {
            IList<TheLoaiViewModel> theLoaiViewModels = null;

            using (var ctx = new BANTINCOVIDEntities())
            {
                theLoaiViewModels = ctx.THELOAI.Select(s => new TheLoaiViewModel()
                {
                    MaTheLoai = s.MATHELOAI,
                    TenTheLoai = s.TENTHELOAI, 
                    MoTa = s.MOTA, 
                    TrangThai = s.TRANGTHAI
                }).ToList<TheLoaiViewModel>();
            }

            if (theLoaiViewModels.Count == 0)
            {
                return NotFound();
            }

            return Ok(theLoaiViewModels);
        }
        //public IHttpActionResult GetAllTinTucByTheLoai(string idTheLoai)
        //{
        //    IList<TinTucModel> tinTucs = null;

        //    using (var ctx = new BANTINCOVID2Entities())
        //    {
        //        tinTucs = ctx.TINTUCs.Where(s => s.MATHELOAI.ToLower() == idTheLoai.ToLower())
        //            .Select(s => new TinTucModel()
        //            {
        //                idTinTuc = s.MATINTUC,
        //                tenTinTuc = s.TENTINTUC,
        //                idTheLoai = s.MATHELOAI,
        //                noiDung = s.NOIDUNG,
        //                noiDungNgan = s.NOIDUNGNGAN,
        //                tacGia = s.TACGIA,
        //                idNhanVien = s.MANHANVIEN,
        //            }).ToList<TinTucModel>();
        //    }

        //    if (tinTucs.Count == 0)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(tinTucs);
        //}
        public IHttpActionResult PostNewTheLoai(TheLoaiViewModel theLoaiViewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            using (var ctx = new BANTINCOVIDEntities())
            {
                ctx.THELOAI.Add(new THELOAI()
                {
                    MATHELOAI = theLoaiViewModel.MaTheLoai,
                    TENTHELOAI = theLoaiViewModel.TenTheLoai, 
                    MOTA = theLoaiViewModel.MoTa, 
                    TRANGTHAI = theLoaiViewModel.TrangThai
                });

                ctx.SaveChanges();
            }

            return Ok();
        }
        public IHttpActionResult PutTinTuc(TheLoaiViewModel theLoaiViewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            using (var ctx = new BANTINCOVIDEntities())
            {
                var existingTheLoai = ctx.THELOAI.Where(s => s.MATHELOAI == theLoaiViewModel.MaTheLoai)
                                                        .FirstOrDefault<THELOAI>();

                if (existingTheLoai != null)
                {
                    existingTheLoai.MATHELOAI = theLoaiViewModel.MaTheLoai;
                    existingTheLoai.TENTHELOAI = theLoaiViewModel.TenTheLoai;
                    existingTheLoai.MOTA = theLoaiViewModel.MoTa;
                    existingTheLoai.TRANGTHAI = theLoaiViewModel.TrangThai;
                    ctx.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }
            return Ok();
        }
        public IHttpActionResult DeleteTheLoai(string maTheLoai)
        {
            if (maTheLoai == "")
                return BadRequest("Not a valid Tin Tuc id");

            using (var ctx = new BANTINCOVIDEntities())
            {
                var theLoai = ctx.THELOAI
                    .Where(s => s.MATHELOAI == maTheLoai)
                    .FirstOrDefault();

                ctx.Entry(theLoai).State = System.Data.Entity.EntityState.Deleted;
                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}
