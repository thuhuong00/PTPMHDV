using BanTinCovidAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BanTinCovidAPI.Controllers.API
{
    public class TinhHinhChungController : ApiController
    {
        public IHttpActionResult GetAllTinhHinhChung()
        {
            IList<TinhHinhChungViewModel> tinhHinhChungViewModels = null;

            using (var ctx = new BANTINCOVIDEntities())
            {
                tinhHinhChungViewModels = ctx.TINHHINHCHUNG.Select(s => new TinhHinhChungViewModel()
                {
                    Ngay = s.NGAY,
                    CaNhiem = s.CANHIEM,
                    ChuaKhoi = s.CHUAKHOI,
                    TuVong = s.TUVONG,
                    MaNhanVien = s.MANHANVIEN,
                }).ToList<TinhHinhChungViewModel>();
            }

            if (tinhHinhChungViewModels.Count == 0)
            {
                return NotFound();
            }

            return Ok(tinhHinhChungViewModels);
        }
        public IHttpActionResult GetAllTinhHinhChungByNhanVien(string maNhanVien)
        {
            IList<TinhHinhChungViewModel> tinhHinhChungViewModels = null;

            using (var ctx = new BANTINCOVIDEntities())
            {
                tinhHinhChungViewModels = ctx.TINHHINHCHUNG.Where(s => s.MANHANVIEN.ToLower() == maNhanVien.ToLower())
                    .Select(s => new TinhHinhChungViewModel()
                    {

                        Ngay = s.NGAY,
                        CaNhiem = s.CANHIEM,
                        ChuaKhoi = s.CHUAKHOI,
                        TuVong = s.TUVONG,
                        MaNhanVien = s.MANHANVIEN,


                    }).ToList<TinhHinhChungViewModel>();
            }

            if (tinhHinhChungViewModels.Count == 0)
            {
                return NotFound();
            }

            return Ok(tinhHinhChungViewModels);
        }
        public IHttpActionResult PostNewTinhHinhChung(TinhHinhChungViewModel tinhHinhChungViewModels)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            using (var ctx = new BANTINCOVIDEntities())
            {
                ctx.TINHHINHCHUNG.Add(new TINHHINHCHUNG()
                {
                    NGAY = tinhHinhChungViewModels.Ngay,
                    CANHIEM = tinhHinhChungViewModels.CaNhiem,
                    CHUAKHOI = tinhHinhChungViewModels.ChuaKhoi,
                    TUVONG = tinhHinhChungViewModels.TuVong,
                    MANHANVIEN = tinhHinhChungViewModels.MaNhanVien
                });

                ctx.SaveChanges();
            }

            return Ok();
        }
        public IHttpActionResult PutTinhHinhChung(TinhHinhChungViewModel tinhHinhChungViewModels)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            using (var ctx = new BANTINCOVIDEntities())
            {
                var existingTinhHinhChung = ctx.TINHHINHCHUNG.Where(s => s.NGAY == tinhHinhChungViewModels.Ngay)
                                                        .FirstOrDefault<TINHHINHCHUNG>();

                if (existingTinhHinhChung != null)
                {
                    existingTinhHinhChung.NGAY = tinhHinhChungViewModels.Ngay;
                    existingTinhHinhChung.CANHIEM = tinhHinhChungViewModels.CaNhiem;
                    existingTinhHinhChung.CHUAKHOI = tinhHinhChungViewModels.ChuaKhoi;
                    existingTinhHinhChung.TUVONG = tinhHinhChungViewModels.TuVong;
                    existingTinhHinhChung.MANHANVIEN = tinhHinhChungViewModels.MaNhanVien;
                   

                    ctx.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }
            return Ok();
        }
        public IHttpActionResult DeleteTheLoai(DateTime ngay)
        {
            //if (ngay )
            //{
            //    return BadRequest("Not a valid Tin Tuc id");
            //}

            using (var ctx = new BANTINCOVIDEntities())
            {
                var tinhhinhchung = ctx.TINHHINHCHUNG
                    .Where(s => s.NGAY == ngay)
                    .FirstOrDefault();

                ctx.Entry(tinhhinhchung).State = System.Data.Entity.EntityState.Deleted;
                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}
