﻿namespace Features.Feature
{
    public abstract class FeatureBase
    {

        /// <summary>
        /// Name of Feature
        /// </summary>
        /// <returns>The feature name</returns>
        public abstract string ID();

        /// <summary>
        /// Tooltip text of sssessments
        /// </summary>
        /// <returns>The feature tooltip</returns>
        public abstract string Info();

        /// <summary>
        /// Checks whether Features should be applied
        /// </summary>
        /// <returns>Returns true if the feature should be applied, false otherwise.</returns>
        public abstract bool CheckFeature();

        /// <summary>
        /// Do the Feature
        /// </summary>
        /// <returns>Returns true if the feature was successfull, false otherwise.</returns>
        public abstract bool DoFeature();

        /// <summary>
        /// Undo the Feature
        /// </summary>
        /// <returns>Returns true if the feature was successfull, false otherwise.</returns>
        public abstract bool UndoFeature();

    }
}