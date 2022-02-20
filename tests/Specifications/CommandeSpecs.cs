using Xunit;
using FluentAssertions;
using Core;

namespace specifications
{
    public class CommandeSpecs
    {
        [Fact]
        public void Should_Execute()
        {
            // Act
            var commande = new Commande("1 + 1");
            var act = () => commande.Execute();

            // Assert
            act.Should().NotThrow();
        }
    }
}