using System.Collections.Generic;
using System.Linq;

namespace WPFineCalc5
{
    public static class Offenses
    {

        public enum MovingViolations
        {
            IllegalParking,
            ImproperLaneChange,
            DrivingWithNoHeadlights,
            UnroadworthyVehicle,
            IllegalUTurn,
            FailureToYieldToEV,
            ImpedingTheFlowOfTraffic,
            Speeding,
            RunningRedLight_StopSign,
            DrivingUnderTheInfluence,
            StuntDriving,
            DragRacing,
            StreetRacing,
            DrivingWithoutALicense,
            DrivingTheWrongWay,
            HitAndRun,
            CarelessDriving
        }

        /// <summary>
        /// A mapping from a MovingViolation to the fine, title and number of jail days.
        /// </summary>
        public static Dictionary<MovingViolations, (int Fine, string Text, int DaysInJail)> MovingViolationData = new Dictionary<MovingViolations, (int Fine, string Text, int DaysInJail)>
        {
            [MovingViolations.IllegalParking] = (100, "Illegal Parking", 0),
            [MovingViolations.ImproperLaneChange] = (150, "Improper Lane Change", 0),
            [MovingViolations.DrivingWithNoHeadlights] = (150, "Driving With No Headlights", 0),
            [MovingViolations.UnroadworthyVehicle] = (500, "Unroadworthy Vehicle", 0),
            [MovingViolations.IllegalUTurn] = (150, "Illegal U-Turn", 0),
            [MovingViolations.FailureToYieldToEV] = (1000, "Failure To Yield To EV", 0),
            [MovingViolations.ImpedingTheFlowOfTraffic] = (300, "Impeding The Flow of Traffic", 0),
            [MovingViolations.Speeding] = (1000, "Speeding", 0),
            [MovingViolations.RunningRedLight_StopSign] = (150, "Running Red Light/Stop Sign", 0),
            [MovingViolations.DrivingUnderTheInfluence] = (2000, "Driving Under The Influence", 20),
            [MovingViolations.StuntDriving] = (2000, "Stunt Driving", 0),
            [MovingViolations.DragRacing] = (2000, "Drag Racing", 0),
            [MovingViolations.StreetRacing] = (2000, "Street Racing", 0),
            [MovingViolations.DrivingWithoutALicense] = (500, "Driving Without A License", 0),
            [MovingViolations.DrivingTheWrongWay] = (500, "Driving The Wrong Way", 0),
            [MovingViolations.HitAndRun] = (2000, "Hit And Run", 5),
            [MovingViolations.CarelessDriving] = (5000, "Careless Driving", 10),
        };

        public static Dictionary<string, MovingViolations> _ViolationByName;
        public static Dictionary<string, MovingViolations> ViolationByName => _ViolationByName ??= MovingViolationData.ToDictionary(kvp => kvp.Value.Text, kvp => kvp.Key);



        public enum Misdemeanors
        {
            Harassment,
            PublicDamage,
            PrivateDamage,
            GovernmentDamage,
            PublicIntoxication,
            Obstruction,
            DisturbingThePeace,
            DischargeofAFirearm,
            AttemptedRobbery,
            AttemptedGTA,
            PossessionofRawIllegalDrugs,
            Loitering,
            AccessoryToACrime,
            Assault,
            ResistingArrest,
            AnimalAbuse,
            Misuseof911,
            Bribery,
            ContemptofCourt,
            FailureToProvideDriversLicense,
            Level1IllegalWeapon,
            Level2IllegalWeapon
        }

        /// <summary>
        /// A mapping from a MovingViolation to the fine, title and number of jail days.
        /// </summary>
        public static Dictionary<Misdemeanors, (int Fine, string Text, int DaysInJail)> MisdemeanorsData = new Dictionary<Misdemeanors, (int Fine, string Text, int DaysInJail)>
        {
            [Misdemeanors.Harassment] = (250, "Harassment", 0),
            [Misdemeanors.PublicDamage] = (1500, "Public Damage", 5),
            [Misdemeanors.PrivateDamage] = (1000, "Private Damage", 0),
            [Misdemeanors.GovernmentDamage] = (2500, "Government Damage", 7),
            [Misdemeanors.PublicIntoxication] = (50, "Public Intoxication", 10),
            [Misdemeanors.Obstruction] = (500, "Obstruction", 15),
            [Misdemeanors.DisturbingThePeace] = (1000, "Disturbing The Peace", 10),
            [Misdemeanors.DischargeofAFirearm] = (1500, "Discharge of A Firearm", 15),
            [Misdemeanors.AttemptedRobbery] = (1000, "Attempted Robbery", 10),
            [Misdemeanors.AttemptedGTA] = (500, "Attempted GTA", 10),
            [Misdemeanors.PossessionofRawIllegalDrugs] = (1500, "Possession of Raw Illegal Drugs", 10),
            [Misdemeanors.Loitering] = (250, "Loitering", 0),
            [Misdemeanors.AccessoryToACrime] = (1000, "Accessory To A Crime", 10),
            [Misdemeanors.Assault] = (1500, "Assault", 20),
            [Misdemeanors.ResistingArrest] = (500, "Resisting Arrest", 10),
            [Misdemeanors.AnimalAbuse] = (2000, "Animal Abuse", 30),
            [Misdemeanors.Misuseof911] = (500, "Misuse of 911", 0),
            [Misdemeanors.Bribery] = (500, "Bribery", 5),
            [Misdemeanors.ContemptofCourt] = (1000, "Contempt of Court", 10),
            [Misdemeanors.FailureToProvideDriversLicense] = (750, "Failure To Provide Drivers License", 0),
            [Misdemeanors.Level1IllegalWeapon] = (1000, "Level 1 Illegal Weapon", 10),
            [Misdemeanors.Level2IllegalWeapon] = (2000, "Level 2 Illegal Weapon", 15),
        };

        public static Dictionary<string, Misdemeanors> _MisdemeanorByName;
        public static Dictionary<string, Misdemeanors> MisdemeanorByName => _MisdemeanorByName ??= MisdemeanorsData.ToDictionary(kvp => kvp.Value.Text, kvp => kvp.Key);



        public enum Felonies
        {
            Stalking,
            ForcibleConfinementofAResident,
            ForcibleConfinementofACityWorker,
            RecklessDriving,
            FelonyEvading,
            PossessionofAStolenVehicle,
            AggravatedAssault,
            AssaultOnACityWorker,
            AttemptedMurderofACivilian,
            AttemptedMurderofACityWorker,
            Manslaughter,
            UnarmedRobbery,
            ArmedRobbery,
            IntentToDistribute,
            PossessionofDirtyMoney,
            Level3IllegalWeapon,
            UnarmedGTA,
            ArmedGTA,
            Extortion,
            DrivingWithSuspendedLicense,
            ContrabandTrafficking,
        }
    public static Dictionary<Felonies, (int Fine, string Text, int DaysInJail)> FeloniesData = new Dictionary<Felonies, (int Fine, string Text, int DaysInJail)>
    {
        [Felonies.Stalking] = (2000, "Stalking", 10),
        [Felonies.ForcibleConfinementofAResident] = (5000, "FC. of A Resident", 15),
        [Felonies.ForcibleConfinementofACityWorker] = (10000, "FC. of A City Worker", 30),
        [Felonies.RecklessDriving] = (7500, "Reckless Driving", 20),
        [Felonies.FelonyEvading] = (10000, "Felony Evading", 20),
        [Felonies.PossessionofAStolenVehicle] = (1500, "Possession of A Stolen Vehicle", 15),
        [Felonies.AggravatedAssault] = (2500, "Aggravated Assault", 20),
        [Felonies.AssaultOnACityWorker] = (3000, "Assault On A CityWorker", 30),
        [Felonies.AttemptedMurderofACivilian] = (10000, "Att. Murder of A Civilian", 30),
        [Felonies.AttemptedMurderofACityWorker] = (25000, "Att. Murder of A City Worker", 60),
        [Felonies.Manslaughter] = (3000, "Manslaughter", 25),
        [Felonies.UnarmedRobbery] = (2000, "Unarmed Robbery", 15),
        [Felonies.ArmedRobbery] = (4500, "Armed Robbery", 30),
        [Felonies.IntentToDistribute] = (750, "Intent To Distribute", 5),
        [Felonies.PossessionofDirtyMoney] = (3000, "Possession of Dirty Money", 7),
        [Felonies.Level3IllegalWeapon] = (12500, "Level 3 Illegal Weapon", 20),
        [Felonies.UnarmedGTA] = (1000, "Unarmed GTA", 20),
        [Felonies.ArmedGTA] = (2000, "Armed GTA", 20),
        [Felonies.Extortion] = (2500, "Extortion", 15),
        [Felonies.DrivingWithSuspendedLicense] = (2500, "Driving With Suspended License", 20),
        [Felonies.ContrabandTrafficking] = (1250, "Contraband Trafficking", 10),
    };

    public static Dictionary<string, Felonies> _FeloniesByName;
    public static Dictionary<string, Felonies> FeloniesByName => _FeloniesByName ??= FeloniesData.ToDictionary(kvp => kvp.Value.Text, kvp => kvp.Key);

}
}


    





   



