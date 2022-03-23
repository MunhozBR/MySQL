using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySQL.Entidades;
using System.Linq;

namespace MySQL.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly Contexto db;
        public UsuariosController(Contexto _db)
        {
            db = _db;
        }
        public ActionResult Index()
        {
            return View(db.USUARIOS.ToList());
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Usuario dadosQueVemTela)
        {
<<<<<<< HEAD
            db.USUARIOS.Add(dadosQueVemTela);
            db.SaveChanges();

            return RedirectToAction("index");

=======
            return RedirectToAction("Index");
>>>>>>> 4d3f4c3a2b97e5013c0e05ddc5536809af716a97
        }


        public ActionResult Edit(int id)
        {
            return View(db.USUARIOS.Where( a => a.Id == id ).FirstOrDefault());
        }


        [HttpPost]
        public ActionResult Edit(int id, Usuario dadosQueVemTela)
        {
<<<<<<< HEAD
            db.USUARIOS.Update(dadosQueVemTela);
            db.SaveChanges();
=======
>>>>>>> 4d3f4c3a2b97e5013c0e05ddc5536809af716a97
            return RedirectToAction("index");
        }

        // GET: UsuariosController/Delete/5
        public ActionResult Delete(int id)
        {
            db.USUARIOS.Remove(
                db.USUARIOS.Where(a => a.Id == id).FirstOrDefault()
                );
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
