﻿/* 
 PureMVC C# Multi-Core Port by Tang Khai Phuong <phuong.tang@puremvc.org>, et al.
 PureMVC - Copyright(c) 2006-08 Futurescale, Inc., Some rights reserved. 
 Your reuse is governed by the Creative Commons Attribution 3.0 License 
*/

using PureMVC.Interfaces;
using PureMVC.Patterns;

namespace PureMVC.Tests.Patterns
{
    /**
	 * A SimpleCommand subclass used by MacroCommandTestCommand.
	 *
  	 * @see org.puremvc.csharp.patterns.command.MacroCommandTest MacroCommandTest
  	 * @see org.puremvc.csharp.patterns.command.MacroCommandTestCommand MacroCommandTestCommand
  	 * @see org.puremvc.csharp.patterns.command.MacroCommandTestVO MacroCommandTestVO
	 */
    public class MacroCommandTestSub2Command : SimpleCommand
    {
        /**
		 * Constructor.
		 */
        public MacroCommandTestSub2Command()
        { }
		
		/**
		 * Fabricate a result by multiplying the input by itself
		 * 
		 * @param event the <code>IEvent</code> carrying the <code>MacroCommandTestVO</code>
		 */
		public override void Execute(INotification note)
		{
			var vo = (MacroCommandTestVO) note.Body;
			
			// Fabricate a result
			vo.result2 = vo.input * vo.input;
		}
    }
}
