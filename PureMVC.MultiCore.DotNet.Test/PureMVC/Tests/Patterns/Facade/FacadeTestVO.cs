﻿/* 
 PureMVC C# Multi-Core Port by Tang Khai Phuong <phuong.tang@puremvc.org>, et al.
 PureMVC - Copyright(c) 2006-08 Futurescale, Inc., Some rights reserved. 
 Your reuse is governed by the Creative Commons Attribution 3.0 License 
*/

namespace PureMVC.Tests.Patterns
{
    /**
  	 * A utility class used by FacadeTest.
  	 * 
  	 * @see org.puremvc.csharp.patterns.facade.FacadeTest FacadeTest
  	 * @see org.puremvc.csharp.patterns.facade.FacadeTestCommand FacadeTestCommand
  	 */
    public class FacadeTestVO
    {
        /**
		 * Constructor.
		 * 
		 * @param input the number to be fed to the FacadeTestCommand
		 */
		public FacadeTestVO(int input)
        {
			this.input = input;
		}

		public int input;
        public int result;
    }
}
