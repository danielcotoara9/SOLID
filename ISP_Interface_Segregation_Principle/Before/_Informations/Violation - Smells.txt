
ISP : Interface Segregations Principle - Code Smells

1) Unimplemented interface methods

public override string ResetPassword(string userName)
{
	throw new NotImplementedException();
}

This is a smell that violates the LSP as well!

2) Client references a class but use only small portion of it



