class Config
{
    #region General Agent Options
    public int totalAgents;
    public float agentRatio;
    public bool rndSpawn;
    #endregion

    #region Prey Options
    public float preyMaxSpawnRad;
    public float preyMinSpawnRad;
    public int preySpawnPosY;
    public int preySpawnPosX;
    public float preyMaxMass;
    public float preyMinMass;
    public float preyMaxSize;
    public float preyMinSize;
    public float preyMaxStartVel;
    public float preyMinStartVel;
    public float preyMaxAccel;
    public float preyMinAccel;
    #endregion

    #region Predator Options
    public float predMaxSpawnRad;
    public float predMinSpawnRad;
    public int predSpawnPosY;
    public int predSpawnPosX;
    public float predMaxMass;
    public float predMinMass;
    public float predMaxSize;
    public float predMinSize;
    public float predMaxVel;
    public float predMinVel;
    public float predMaxAccel;
    public float predMinAccel;
    #endregion

    #region Prey Behaviours
    public float preyFleeMaxInf;
    public float preyFleeMinInf;
    public float preyFleeMaxAng;
    public float preyFleeMinAng;
    public float preyFleeMaxRad;
    public float preyFleeMinRad;
    public bool preyFleeEnabled;

    public float preySpeedMaxInf;
    public float preySpeedMinInf;
    public float preySpeedMaxAng;
    public float preySpeedMinAng;
    public float preySpeedMaxRad;
    public float preySpeedMinRad;
    public bool preySpeedEnabled;

    public float preyHeadingMaxInf;
    public float preyHeadingMinInf;
    public float preyHeadingMaxAng;
    public float preyHeadingMinAng;
    public float preyHeadingMaxRad;
    public float preyHeadingMinRad;
    public bool preyHeadingEnabled;

    public float preyGroupingMaxInf;
    public float preyGroupingMinInf;
    public float preyGroupingMaxAng;
    public float preyGroupingMinAng;
    public float preyGroupingMaxRad;
    public float preyGroupingMinRad;
    public bool preyGroupingEnabled;

    public float preyAvoidanceMaxInf;
    public float preyAvoidanceMinInf;
    public float preyAvoidanceMaxAng;
    public float preyAvoidanceMinAng;
    public float preyAvoidanceMaxRad;
    public float preyAvoidanceMinRad;
    public bool preyAvoidanceEnabled;
    #endregion

    #region Predator Behaviours
    public float predChaseMaxInf;
    public float predChaseMinInf;
    public float predChaseMaxAng;
    public float predChaseMinAng;
    public float predChaseMaxRad;
    public float predChaseMinRad;
    public bool predChaseEnabled;

    public float predFleeMaxInf;
    public float predFleeMinInf;
    public float predFleeMaxAng;
    public float predFleeMinAng;
    public float predFleeMaxRad;
    public float predFleeMinRad;
    public bool predFleeEnabled;

    public float predSpeedMaxInf;
    public float predSpeedMinInf;
    public float predSpeedMaxAng;
    public float predSpeedMinAng;
    public float predSpeedMaxRad;
    public float predSpeedMinRad;
    public bool predSpeedEnabled;

    public float predHeadingMaxInf;
    public float predHeadingMinInf;
    public float predHeadingMaxAng;
    public float predHeadingMinAng;
    public float predHeadingMaxRad;
    public float predHeadingMinRad;
    public bool predHeadingEnabled;

    public float predGroupingMaxInf;
    public float predGroupingMinInf;
    public float predGroupingMaxAng;
    public float predGroupingMinAng;
    public float predGroupingMaxRad;
    public float predGroupingMinRad;
    public bool predGroupingEnabled;

    public float predAvoidanceMaxInf;
    public float predAvoidanceMinInf;
    public float predAvoidanceMaxAng;
    public float predAvoidanceMinAng;
    public float predAvoidanceMaxRad;
    public float predAvoidanceMinRad;
    public bool predAvoidanceEnabled;
    #endregion

    #region Client Options
    public float clientPhysInt;
    public bool frameRateLockEnabled;
    public int frameRateCapAmt;
    #endregion

    #region Client Network
    public string clientConnectIP;
    public bool broadcastEnabled;
    public uint clientConnectPort;
    #endregion

    #region Server Options
    public int serverMaxClients;
    public int maxAgentsPerC;
    public float serverPhysInt;
    #endregion

    #region Server Network
    public uint serverPort;
    #endregion
}
