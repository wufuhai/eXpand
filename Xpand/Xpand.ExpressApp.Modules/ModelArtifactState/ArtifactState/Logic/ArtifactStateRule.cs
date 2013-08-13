﻿using Xpand.ExpressApp.Logic;

namespace Xpand.ExpressApp.ModelArtifactState.ArtifactState.Logic {
    public abstract class ArtifactStateRule : LogicRule, IArtifactStateRule {
        protected ArtifactStateRule(IArtifactStateRule artifactStateRule)
            : base(artifactStateRule) {
            Module = artifactStateRule.Module;
        }

        public string Module { get; set; }
    }
}