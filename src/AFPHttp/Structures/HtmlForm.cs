namespace CjrHttp.Structures
{
    using System.Collections.Generic;
    using System.Linq;
    using CJR.Common.Extensions;

    public class HtmlForm
    {
        private readonly List<HtmlInput> _inputFields = new List<HtmlInput>();

 
        public string Action { get; set; }
        public string Name { get; set; }
        public IEnumerable<HtmlInput> InputFields { get { return _inputFields;  } }
        public IEnumerable<HtmlInput> WritableFields { get { return _inputFields.Where(f => f.IsWritable); } }

        public byte[] ContentBuffer
        {
            get { return Content.ToByteArray(); }
        }

        public string Content
        {
            get { return string.Join("&", _inputFields.Select(f => f.Text)); }
        }

        public IEnumerable<HtmlInput> FieldsTyped(string type)
        {
            return _inputFields.Where(f => f.Type.ToUpper() == type.ToUpper());
        }
        public HtmlInput FieldNamed(string name)
        {
            return _inputFields.Find(f => f.Name.ToUpper() == name.ToUpper());
        }
        public void Add(HtmlInput input)
        {
            _inputFields.Add(input);
        }

    }
}