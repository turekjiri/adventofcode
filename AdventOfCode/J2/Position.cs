namespace J2
{
    class Position
    {
        public int Depth { get; set; }

        public int Horizontal { get; set; }

        public int Aim { get; set; }

        public Position()
        {
            this.Depth = 0;
            this.Horizontal = 0;
            this.Aim = 0;
        }


        /*
         * down X increases your aim by X units
         */
        public void Down(int val)
        {
            this.Aim += val;
        }

        /*
         * up X decreases your aim by X units
         */
        public void Up(int val)
        {
            this.Aim -= val;
        }

        /*
         * forward X does two things:
         *   - It increases your horizontal position by X units
         *   - It increases your depth by your aim multiplied by X
         */
        public void Forward(int val)
        {
            this.Horizontal += val;
            this.Depth += (this.Aim * val);
        }

        /*
         * Using this new interpretation of the commands, 
         * calculate the horizontal position and depth you would have after following the planned course. 
         * What do you get if you multiply your final horizontal position by your final depth?
         */
        public int GetResult()
        {
            return this.Horizontal * this.Depth;
        }
    }
}
