using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esri.FileGDB;
using System.IO;

namespace gdbManager
{
    class Read
    {
        public static List<string> pointsChildDatasets = new List<string>();
        public static List<string> linesChildDatasets = new List<string>();
        public static List<string> PolygonsChildDatasets = new List<string>();
        public static void ReadData(string path)
        {
            try
            {
                Geodatabase geodatabase = Geodatabase.Open(path);
                foreach (var ds in geodatabase.GetChildDatasets("\\", string.Empty))
                {
                    string sqlStatement = @"SELECT * FROM " + ds.Substring(1);
                    foreach (Row attrQueryRow in geodatabase.ExecuteSQL(sqlStatement))
                    {

                        for (int nFieldNumber = 0; nFieldNumber < attrQueryRow.FieldInformation.Count; nFieldNumber++)
                        {
                            string fieldName = attrQueryRow.FieldInformation.GetFieldName(nFieldNumber);
                            if (attrQueryRow.IsNull(fieldName))
                                continue;

                            switch (attrQueryRow.FieldInformation.GetFieldType(nFieldNumber))
                            {
                                case FieldType.SmallInteger:
                                    attrQueryRow.GetShort(fieldName);
                                    break;
                                case FieldType.Integer:
                                    attrQueryRow.GetInteger(fieldName);
                                    break;
                                case FieldType.Single:
                                    attrQueryRow.GetFloat(fieldName);
                                    break;
                                case FieldType.Double:
                                    attrQueryRow.GetDouble(fieldName);
                                    break;
                                case FieldType.String:
                                    attrQueryRow.GetString(fieldName);
                                    break;
                                case FieldType.Date:
                                    attrQueryRow.GetDate(fieldName).ToShortTimeString();
                                    break;
                                case FieldType.OID:
                                    attrQueryRow.GetOID();
                                    break;
                                case FieldType.Geometry:
                                    byte[] shapeBuffer = attrQueryRow.GetGeometry().shapeBuffer;
                                    double[] vs = new double[shapeBuffer.Length / 8];

                                    for (int i = 0; i < vs.Length; i++)
                                        vs[i] = BitConverter.ToDouble(shapeBuffer, i * 8);

                                    break;
                                case FieldType.GUID:
                                    attrQueryRow.GetGUID(fieldName).ToString();
                                    break;
                                case FieldType.GlobalID:
                                    attrQueryRow.GetGlobalID().ToString();
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
                geodatabase.Close();
            }
            catch (Exception)
            {
                return;
            }
        }

        public static bool ReadOnlyTheLyrs(string path, int i)
        {
            try
            {
                Geodatabase geodatabase = Geodatabase.Open(path);
                if (i == 1)
                    foreach (var ds in geodatabase.GetChildDatasets("\\", string.Empty))
                        pointsChildDatasets.Add(ds.Substring(1));
                else if (i == 2)
                    foreach (var ds in geodatabase.GetChildDatasets("\\", string.Empty))
                        linesChildDatasets.Add(ds.Substring(1));
                else if (i == 3)
                    foreach (var ds in geodatabase.GetChildDatasets("\\", string.Empty))
                        PolygonsChildDatasets.Add(ds.Substring(1));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

    }
}
