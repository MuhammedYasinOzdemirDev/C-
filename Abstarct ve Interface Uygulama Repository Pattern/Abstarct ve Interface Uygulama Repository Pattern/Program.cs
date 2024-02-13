using Abstarct_ve_Interface_Uygulama_Repository_Pattern;
using Abstarct_ve_Interface_Uygulama_Repository_Pattern.DataAccesss.Concreate;
using Abstarct_ve_Interface_Uygulama_Repository_Pattern.Entity;

var productdal = new EFProductDal();
productdal.Create(new Product());
var productrepository = new ProductManager(new EFProductDal());