using BanTinCovidAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BanTinCovidAPI.Controllers.API
{
    public class TinTucController : ApiController
    {
        public IHttpActionResult GetAllTinTuc()
        {
            IList<TinTucViewModel> tinTucViewModels = null;

            using (var ctx = new BANTINCOVIDEntities())
            {
                tinTucViewModels = ctx.TINTUC.Select(s => new TinTucViewModel()
                {
                    MaTinTuc = s.MATINTUC,
                    TenTinTuc = s.TENTINTUC,
                    MaTheLoai = s.MATHELOAI, 
                    NoiDung = s.NOIDUNG,
                    NoiDungNgan = s.NOIDUNGNGAN, 
                    TacGia = s.TACGIA, 
                    MaNhanVien = s.MANHANVIEN, 
                    Ngay = s.NGAY

                    
                    
                }).ToList<TinTucViewModel>();
            }

            if (tinTucViewModels.Count == 0)
            {
                return NotFound();
            }

            return Ok(tinTucViewModels);
            //return Ok(tinTucViewModels.OrderByDescending(s => s.Ngay));
        }
        public IHttpActionResult GetAllTinTucByTheLoai(string maTheLoai)
        {
            IList<TinTucViewModel>  tinTuc = null;

            using (var ctx = new BANTINCOVIDEntities())
            {
                tinTuc = ctx.TINTUC.Where(s => s.MATHELOAI.ToLower() == maTheLoai.ToLower())
                    .Select(s => new TinTucViewModel()
                    {
                        MaTinTuc = s.MATINTUC,
                        TenTinTuc = s.TENTINTUC,
                        MaTheLoai = s.MATHELOAI,
                        NoiDung = s.NOIDUNG,
                        NoiDungNgan = s.NOIDUNGNGAN,
                        TacGia = s.TACGIA,
                        MaNhanVien = s.MANHANVIEN,
                        Ngay = s.NGAY
                    }).ToList<TinTucViewModel>();
            }

            if (tinTuc.Count == 0)
            {
                return NotFound();
            }

            return Ok(tinTuc);
        }
        public IHttpActionResult PostNewTinTuc(TinTucViewModel tinTucViewModels)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            using (var ctx = new BANTINCOVIDEntities())
            {
                ctx.TINTUC.Add(new TINTUC()
                {

                    MATINTUC = tinTucViewModels.MaTinTuc, 
                    TENTINTUC = tinTucViewModels.TenTinTuc, 
                    MATHELOAI = tinTucViewModels.MaTheLoai, 
                    TACGIA = tinTucViewModels.TacGia, 
                    NOIDUNG = tinTucViewModels.NoiDung,
                    NOIDUNGNGAN = tinTucViewModels.NoiDungNgan, 
                    MANHANVIEN = tinTucViewModels.MaNhanVien, 
                    NGAY = tinTucViewModels.Ngay
                });
                ctx.SaveChanges();
            }

            return Ok();
        }
        public IHttpActionResult PutTinTuc(TinTucViewModel tinTucViewModels)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            using (var ctx = new BANTINCOVIDEntities())
            {
                var existingTinTuc = ctx.TINTUC.Where(s => s.MATINTUC == tinTucViewModels.MaTinTuc)
                                                        .FirstOrDefault<TINTUC>();

                if (existingTinTuc != null)
                {
                    existingTinTuc.MATHELOAI = tinTucViewModels.MaTheLoai;
                    existingTinTuc.TENTINTUC = tinTucViewModels.TenTinTuc;
                    existingTinTuc.MATHELOAI = tinTucViewModels.MaTheLoai;
                    existingTinTuc.NOIDUNG = tinTucViewModels.NoiDung;
                    existingTinTuc.NOIDUNGNGAN = tinTucViewModels.NoiDungNgan;
                    existingTinTuc.MANHANVIEN = tinTucViewModels.MaNhanVien;
                    existingTinTuc.NGAY = tinTucViewModels.Ngay;
                    ctx.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }
            return Ok();
        }
        public IHttpActionResult DeleteTinTuc(int maTinTuc)
        {
            if (maTinTuc == null)
                return BadRequest("Not a valid Ma Tin Tuc");

            using (var ctx = new BANTINCOVIDEntities())
            {
                var tintuc = ctx.TINTUC
                    .Where(s => s.MATINTUC == maTinTuc)
                    .FirstOrDefault();

                ctx.Entry(tintuc).State = System.Data.Entity.EntityState.Deleted;
                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}
