using Import.Domain.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Import.Domain.Core.ImportFiles
{
    public class ImportFile : AggregateRoot<ImportFileId>
    {
        public string Number { get; set; }
        public string Date { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }

        //Public????
        public static ImportFile CreateNew(string number, string date, int status, string description)
        {
            var importFileId = new ImportFileId(Guid.NewGuid());
            return new ImportFile(importFileId, number, date, status, description);
        }

        public static ImportFile CreateNewForUpdate(Guid id, string number, string date, int status, string description)
        {
            var importFileId = new ImportFileId(id);
            return new ImportFile(importFileId, number, date, status, description);
        }

        public static ImportFile CreateNewForDelete(ImportFileId id)
        {
            return new ImportFile(id);
        }

        public void Update(ImportFile newValue)
        {
            Number = newValue.Number;
            Date = newValue.Date;
            Status = newValue.Status;
            Description = newValue.Description;
        }

        public ImportFile(ImportFileId id, string number, string date, int status, string description)
        {
            Id = id;
            Number = number;
            Date = date;
            Status = status;
            Description = description;
        }

        private ImportFile(ImportFileId importFileId)
        {
            Id = importFileId;
        }

        private ImportFile() { }
    }
}
