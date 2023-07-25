using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTesting.Modelos;
using ProjectTesting.Colecciones;
namespace ProjectTesting.Colecciones
{
    public static class ColeccionDatosPrueba
    {
        public static Menus menusPrueba = new Menus();
        public static Viandas viandasPrueba = new Viandas();
        public static Dietas dietasPrueba = new Dietas();


        public static void CargarDatosPrueba()
        {

            //dietas
            Dieta d = new Dieta("Vegetariana", "Sin carnes");
            Dieta d1 = new Dieta("Vegana", "Sin derivados animales");
            Dieta d2 = new Dieta("Celiaca", "Sin gluten");
            Dieta d3 = new Dieta("Para hipertensos", "Sin sal");
            Dieta d4 = new Dieta("Paria diabéticos", "Sin azucar");
            dietasPrueba.AgregarDieta(d);
            dietasPrueba.AgregarDieta(d1);
            dietasPrueba.AgregarDieta(d2);
            dietasPrueba.AgregarDieta(d3);
            dietasPrueba.AgregarDieta(d4);


            //viandas
            Vianda v = new Vianda("Hamburguesa al pan con puré de papas", d4);
            Vianda v1 = new Vianda("Pizza de avena", d2, d1);
            Vianda v2= new Vianda("Estofado de carne con puré", d2);
            Vianda v3 = new Vianda("Polenta rellena con carne", d4);
            Vianda v4 = new Vianda("Polenta rellena de verduras", d, d1, d4);
            Vianda v5 = new Vianda("Milanesas de berenjena con ensalada", d,d1,d4 );
            Vianda v6 = new Vianda("Milanesas de berenjena con ensalada(Opcion sin sal)", d,d3, d1, d4);
            Vianda v7 = new Vianda("Guiso de lentejas", d4 );
            Vianda v8 = new Vianda("Guiso de lentejas (Opcion sin carne)",d, d1, d4);
            Vianda v9 = new Vianda("Sopa crema de espárragos y chuleta de bondiola con papas", d4);
            Vianda v10 = new Vianda("Sopa crema de espárragos y chuleta de bondiola con papas (opcion sin sal)", d3, d4);
            Vianda v11 = new Vianda("Guiso de lentejas (Opcion sin carne)", d, d1, d4);
            Vianda v12 = new Vianda("Sopa crema de espárragos y chuleta de bondiola con papas", d4);
            Vianda v13 = new Vianda("Sopa crema de espárragos y chuleta de bondiola con papas (opcion sin sal)", d3, d4);
            Vianda v14 = new Vianda("Sopa crema de espárragos y chuleta de bondiola con papas (opcion sin sal)", d3, d4);
            Vianda v15 = new Vianda("Sopa crema de espárragos y chuleta de bondiola con papas (opcion sin sal)", d3, d4);
            Vianda v16 = new Vianda("Sopa crema de espárragos y chuleta de bondiola con papas (opcion sin sal)", d3, d4);
            Vianda v17 = new Vianda("Sopa crema de espárragos y chuleta de bondiola con papas", d4);
            Vianda v18 = new Vianda("Sopa crema de espárragos y chuleta de bondiola con papas (opcion sin sal)", d3, d4);
            Vianda v19 = new Vianda("Guiso de lentejas (Opcion sin carne)", d, d1, d4);
            Vianda v20 = new Vianda("Sopa crema de espárragos y chuleta de bondiola con papas", d4);
            viandasPrueba.AgregarViandas(v, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16,v17,v18,v19,v20);

            //Menus
            Viandas viandasMenu1 = new Viandas();
            viandasMenu1.AgregarViandas(v1, v8, v2, v4, v);
            Menu menu1 = new Menu("menu1", tipoMenu.Semanal, viandasMenu1);

            Viandas viandasMenu2 = new Viandas();
            viandasMenu2.AgregarViandas(v2, v4, v, v5, v, v12, v14, v16, v6, v4,v9,v13, v1);
            Menu menu2 = new Menu("menu2",tipoMenu.Quincenal, viandasMenu2);

            Viandas viandasMenu3 = new Viandas();
            viandasMenu3.AgregarViandas(v2, v4, v, v5, v, v12, v14, v16, v6, v4, v9, v13, v1,v,v1,v12,v14,v1,v6,v10);
            Menu menu3 = new Menu("menu3", tipoMenu.Mensual, viandasMenu3);

            menusPrueba.AgregarMenus(menu1, menu2, menu3);

        }





    }
}
