
using BarcodeLib;
using barcodeGenerator;

Barcode barcode =Process.CreateAndSaveBarcode("777");
Console.WriteLine(Process.ReadBarcode(barcode));

barcode = Process.CreateAndSaveBarcode("11");
Console.WriteLine(Process.ReadBarcode(barcode));

barcode = Process.CreateAndSaveBarcode("111");
Console.WriteLine(Process.ReadBarcode(barcode));

barcode = Process.CreateAndSaveBarcode("1111");
Console.WriteLine(Process.ReadBarcode(barcode));