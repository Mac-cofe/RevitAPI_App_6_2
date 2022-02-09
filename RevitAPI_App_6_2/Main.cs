using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создайте приложение, которое позволяет расставлять элементы только из категории «Мебель».
//В приложении должен быть выпадающий список для выбора уровня расположения
//элемента. Расположение элемента в модели указывается с помощью запроса точки
//вставки.

namespace RevitAPI_App_6_2

{
    [Transaction(TransactionMode.Manual)]

    public class Main : IExternalCommand
    {
       
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            TaskDialog.Show("Внимание!", "Сначала необходимо указать левой кнопкой мыши точку вставки экземпляра, а затем в появившемся окне выбрать семейство и уровень");

            var mainView = new MainView(commandData);
            mainView.ShowDialog();
            return Result.Succeeded;
        }
    }
}
