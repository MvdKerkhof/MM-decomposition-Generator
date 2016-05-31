﻿//TreeEdge.cs
//Defines the edges used by the decomposition trees.
using QuickGraph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMDecompositionGenerator.Data_Structures
{
    /// <summary>
    /// Represent a directed edge from a parent node to one of its children.
    /// </summary>
    class TreeEdge : IEquatable<TreeEdge>, IEdge<TreeVertex>
    {
        //The two vertices connected by the edge
        TreeVertex u, v;

        /// <summary>
        /// Makes a new TreeEdge object. The "first" vertex in the edge is always the parent.
        /// </summary>
        /// <param name="u">The parent vertex</param>
        /// <param name="v">The child vertex</param>
        public TreeEdge(TreeVertex u, TreeVertex v)
        {
                this.u = u;
                this.v = v;
        }

        //The parent vertex connected by the edge
        public TreeVertex Source
        {
            get
            {
                return u;
            }
        }

        //The child vertex connected by the edge
        public TreeVertex Target
        {
            get
            {
                return v;
            }
        }

        /// <summary>
        /// Compares this treeedge to another
        /// </summary>
        /// <param name="other">The other tree edge to compare to</param>
        /// <returns>True if the edges are the same, false otherwise</returns>
        public bool Equals(TreeEdge other)
        {
            if (this.u == other.u && this.v == other.v)
                return true;
            else return false;
        }
    }
}
