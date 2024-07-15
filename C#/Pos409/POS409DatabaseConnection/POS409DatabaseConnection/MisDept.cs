using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POS409DatabaseConnection
{
    class MisDept : Employee
    {
        private string _position;

        private string _workArea;

        private int _payGrade;

        public MisDept()
        {
            _position = "";

            _workArea = "";

            _payGrade = 0;
        }

        public string Position
        {
            get { return _position; }

            set { _position = value; }
        }

        public string WorkArea
        {
            get { return _workArea; }

            set { _workArea = value; }
        }

        public int PayGrade
        {
            get { return _payGrade; }

            set { _payGrade = value; }
        }

    }
}
