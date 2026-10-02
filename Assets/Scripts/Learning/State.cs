public struct ObstacleInfo
{
    public int recompensa;
    public int distance;
}

public struct State
{
    public int agentColumn;

    public ObstacleInfo column0;
    public ObstacleInfo column1;
    public ObstacleInfo column2;
    public ObstacleInfo column3;
    public ObstacleInfo column4;
}
