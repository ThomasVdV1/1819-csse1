class DBConnectie
{
    private DBConnectie instance;

    private DBConnectie()
    {
    }

    public DBConnectie Instance() {
        if (instance == null) {
            instance = new DBConnectie();
        }

        return instance;
    }
}
