namespace Shared.Models
{
    public class CaterPillar
    {
        private Dictionary<char, List<int>> _body;
        private char[,] _map { get; set; }
        public CaterPillar(char[,] map)
        {
            _body = new Dictionary<char, List<int>>
            {
                { 'H', new List<int> { 29,0 } },
                { 'T', new List<int> { 29,0 } }
            };
            _map = map;
        }

        public void MoveUp(int steps)
        {
            for (int i = 0; i < steps; i++)
            {                
                if (CheckStart())
                {
                    _body['H'][0]--;

                    UpdateHead();

                    UpdateTail(false);

                    Map.Print(_map);

                    continue;
                }
                // To simulate game like experience
                Thread.Sleep(1000);

                RemoveFrom(_body['H'][0], _body['H'][1]);

                _body['H'][0]--;

                UpdateHead();

                UpdateTail(true);

                // Check for out of range index

                Map.Print(_map);
            }         
        }

        public void Grow()
        {
           
        }

        public void Shrink()
        {
           
        }

        private bool CheckStart()
        {
            if (_body['H'][0] == 29 && _body['H'][1] == 0)
            {
                if (_body['T'][0] == 29 && _body['H'][1] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private void UpdateHead()
        {
            _map[_body['H'][0], _body['H'][1]] = 'H';
        }
        private void RemoveFrom(int row, int col)
        {
            _map[row, col] = '*';
        }

        private void UpdateTail(bool move = true)
        {            
            if (!move)
            {
                PrintStart();

                _map[_body['T'][0], _body['T'][1]] = 'T';

                return;
            }

            RemoveFrom(_body['T'][0], _body['T'][1]);

            _body['T'][0]--;

            _map[_body['T'][0], _body['T'][1]] = 'T';

            PrintStart();
        }
        private void PrintStart()
        {
            _map[29, 0] = 'S';
        }
    }
}
