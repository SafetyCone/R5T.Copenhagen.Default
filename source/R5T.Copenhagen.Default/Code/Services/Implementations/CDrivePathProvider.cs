using System;

using R5T.Canterbury;


namespace R5T.Copenhagen.Default
{
    public class CDrivePathProvider : ICDrivePathProvider
    {
        private ICDriveNameConvention CDriveNameConvention { get; }


        public CDrivePathProvider(ICDriveNameConvention cDriveNameConvention)
        {
            this.CDriveNameConvention = cDriveNameConvention;
        }

        public string GetCDrivePath()
        {
            var cDriveName = this.CDriveNameConvention.GetCDriveName();
            return cDriveName;
        }
    }
}
