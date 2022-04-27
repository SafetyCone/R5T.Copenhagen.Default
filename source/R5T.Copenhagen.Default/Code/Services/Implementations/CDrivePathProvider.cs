using System;

using R5T.Canterbury;using R5T.T0064;


namespace R5T.Copenhagen.Default
{[ServiceImplementationMarker]
    public class CDrivePathProvider : ICDrivePathProvider,IServiceImplementation
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
